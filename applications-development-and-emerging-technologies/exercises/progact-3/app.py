from flask import Flask, render_template, redirect, url_for, request, session
from backend import database
from forms import Add_Employee, Edit_Employee
from models import Employee

app = Flask(__name__)
app.config['SECRET_KEY'] = 'abc'
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///db.sqlite3'

themes = {
    'light' : {'label': 'Light', 'name': 'light'},
    'dark': {'label': 'Dark', 'name': 'business'}}

@app.context_processor
def inject_global_elements():
    session['current_theme'] = themes['light'] if session.get('current_theme') is None else session['current_theme']
    current_theme = session['current_theme']
    employees = Employee.query.all()
    return dict(employees = employees, current_theme = current_theme)


@app.route('/theme/toggle', methods = ['GET', 'POST'])
def theme_toggle():
    if session['current_theme'] == themes['light']:
        session['current_theme'] = themes['dark']
    else:
        session['current_theme'] = themes['light']
    return redirect(url_for('home'))


@app.route("/", methods = ['GET', 'POST'])
@app.route("/home", methods = ['GET', 'POST'])
def home():
    query_request = request.args.get(key = 'keyword')
    search_query = '' if query_request is None else query_request

    fields = [
        Employee.id, Employee.email, Employee.first_name, 
        Employee.middle_name, Employee.last_name, Employee.birthday ]

    results = []
    for field in fields:
        query_results_by_field = (
            Employee.query
            .filter(field.contains(search_query))
            .all() )
        for query_result in query_results_by_field:
            if query_result not in results:
                results.append(query_result)

    return render_template('index.html', employees = results)


@app.route("/add", methods = ['GET', 'POST'])
def add_employee():
    form = Add_Employee()
    if form.validate_on_submit():
        employee = Employee(
            first_name = form.first_name.data,
            middle_name = form.middle_name.data,
            last_name = form.last_name.data,
            email = form.email.data,
            birthday = form.birthday.data, )
        
        database.session.add(employee)
        database.session.commit()
        print("Succesfully created employee")
    return render_template('add.html', form = form)


@app.route('/edit', methods = ['GET', 'POST'])
def edit_employee():
    employee_id = request.args.get(key = 'id', type = int)
    employee = Employee.query.filter_by(id = employee_id).first()

    form = Edit_Employee()
    if form.validate_on_submit():
        employee.first_name = form.first_name.data
        employee.middle_name = form.middle_name.data
        employee.last_name = form.last_name.data
        employee.email = form.email.data
        employee.birthday = form.birthday.data

        database.session.commit()
        print("Changes succesfully saved")
    return render_template('edit.html', form = form, employee = employee)
      


@app.route("/employee/delete_all")
def delete_employee_all():
    with app.app_context():
        database.drop_all()
        database.create_all()
    return redirect(request.referrer)


if __name__ == "__main__":
    database.init_app(app)
    with app.app_context():
        database.create_all()

    app.run(debug=True)