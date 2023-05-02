from flask import Flask, render_template, redirect, url_for
from backend import database
from forms import Add_Employee
from models import Employee

app = Flask(__name__)
app.config['SECRET_KEY'] = 'abc'
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///db.sqlite3'

@app.context_processor
def inject_global_elements():
    employees = Employee.query.all()
    return dict(employees = employees)

@app.route("/", methods = ['GET', 'POST'])
@app.route("/home", methods = ['GET', 'POST'])
def home():
    form = Add_Employee()
    if form.validate_on_submit():
        employee = Employee(
            first_name = form.first_name.data,
            middle_name = form.middle_name.data,
            last_name = form.last_name.data,
            email = form.email.data,
            birthday = form.birthday.data, )
        
        add_employee(employee)
        return redirect(url_for('home'))    
    
    return render_template('index.html', form = form)

def add_employee(employee):        
    database.session.add(employee)
    database.session.commit()
    print("Succesfully created employee")

@app.route("/employee/delete_all")
def employee_delete_all():
    with app.app_context():
        database.drop_all()
        database.create_all()
    return redirect(url_for('home'))


if __name__ == "__main__":
    database.init_app(app)
    with app.app_context():
        database.create_all()

    app.run(debug=True)