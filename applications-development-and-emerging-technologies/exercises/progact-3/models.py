from backend import database

class Employee(database.Model):
    __tablename__ = 'employee'
    id = database.Column(database.Integer, primary_key = True)
    email = database.Column(database.String(40), nullable = False)
    first_name = database.Column(database.String(40), nullable = False)
    middle_name = database.Column(database.String(40), nullable = False)
    last_name = database.Column(database.String(40), nullable = False)
    birthday = database.Column(database.Date, nullable = False)

    def __repr__(self):
        return f"Employee('{self.id}', '{self.first_name}', '{self.last_name}')"
    