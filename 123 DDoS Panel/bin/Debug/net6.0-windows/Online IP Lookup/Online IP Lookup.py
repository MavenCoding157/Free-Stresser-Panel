#Online IP Lookup
import ipapi
from flask import Flask, request, render_template
 
#pip install ipapi
 
 
app = Flask(__name__)
 
 
 
@app.route('/', methods = ['GET', 'POST'])
def Index():
    search = request.form.get('search')
    data = ipapi.location(ip=search, output='json')
    return render_template('index.html', data=data)
 
 
 
 
app.run(host="0.0.0.0", port=80)