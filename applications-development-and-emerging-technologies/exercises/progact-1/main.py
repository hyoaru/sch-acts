from flask import Flask, render_template
from data import data

app = Flask(__name__);

@app.route("/")
def home():
    return render_template(
        'data.html', data_list = data, 
        col_headers = [header for header in data[0].keys()])

if __name__ == '__main__':
    app.run(debug = True)