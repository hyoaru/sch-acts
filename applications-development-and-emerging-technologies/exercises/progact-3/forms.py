from flask_wtf import FlaskForm
from wtforms import StringField, DateField, SubmitField, IntegerField
from wtforms.validators import DataRequired, Length, Email

class Add_Employee(FlaskForm):
    email = StringField(label = 'Email', validators = [DataRequired(), Length(max = 40), Email()], )
    first_name = StringField(label = 'First name', validators = [DataRequired(), Length(max = 40)], )
    middle_name = StringField(label = 'Middle name', validators = [DataRequired(), Length(max = 40)], )
    last_name = StringField(label = 'Last name', validators = [DataRequired(), Length(max = 40)], )
    birthday = DateField(label = 'Birthday', validators = [DataRequired()])
    submit = SubmitField(label = 'Add')

class Edit_Employee(FlaskForm):
    id = IntegerField(label = 'ID', validators = [DataRequired()], )
    email = StringField(label = 'Email', validators = [DataRequired(), Length(max = 40), Email()], )
    first_name = StringField(label = 'First name', validators = [DataRequired(), Length(max = 40)], )
    middle_name = StringField(label = 'Middle name', validators = [DataRequired(), Length(max = 40)], )
    last_name = StringField(label = 'Last name', validators = [DataRequired(), Length(max = 40)], )
    birthday = DateField(label = 'Birthday', validators = [DataRequired()])
    submit = SubmitField(label = 'Save')