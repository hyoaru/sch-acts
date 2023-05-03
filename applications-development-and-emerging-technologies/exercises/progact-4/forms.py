from flask_wtf import FlaskForm
from wtforms import StringField, PasswordField, SubmitField, SelectField, IntegerRangeField, IntegerField
from wtforms.validators import DataRequired, Length, Email, NumberRange

class SignUpForm(FlaskForm):
    username = StringField('Username', validators=[DataRequired(), Length(min=2, max=20)])
    password = PasswordField('Password', validators=[DataRequired(), Length(min=2, max=20)])
    submit = SubmitField('Sign Up')

class Student_Register_Form(FlaskForm):
    first_name = StringField(
        'First name', 
        validators=[DataRequired(), Length(min = 2, max = 50)])
    middle_name = StringField(
        'Middle name', 
        validators=[DataRequired(), Length(min = 2, max = 50)])
    last_name = StringField(
        'Last name', 
        validators=[DataRequired(), Length(min = 2, max = 50)])
    email = StringField(
        'Email address', 
        validators=[DataRequired(), Length(min = 2, max = 50)])
    last_school_attended = SelectField(
        'Last school attended', 
        choices = [('Select last school attended'),('haha'), ('wla'), ('ayoko n')])
    age = IntegerField(
        'Age', validators=[NumberRange(min = 1, max = 100)], )
    phone_number = IntegerField(
        'Phone number', validators = [NumberRange(min = 1, max = 100), ])