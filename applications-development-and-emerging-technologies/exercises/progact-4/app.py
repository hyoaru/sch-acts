from flask import Flask, render_template
from forms import Student_Register_Form

app = Flask(__name__)
app.config['SECRET_KEY'] = 'betlog'

@app.route('/student/register', methods = ['GET', 'POST'])
def student_register():
    form = Student_Register_Form()
    return render_template('student_register.html', registration_form = form)

if __name__ == "__main__":
    app.run(debug=True)