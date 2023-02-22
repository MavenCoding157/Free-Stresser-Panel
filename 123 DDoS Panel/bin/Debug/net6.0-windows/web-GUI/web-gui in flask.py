#web-gui in flask
from flask import Flask, render_template

app = Flask(__name__)

@app.route('/')
def index():
    messagez = ['test1']
    return render_template('Web-GUI', message=messagez)

if __name__ == '__main__':
    app.run()
