
var http = require('http');
var url = require('url');
var path = require('path');
var fs = require('fs');
const express = require('express');

const app = express();
app.use(express.static('static'));
app.use(express.urlencoded({extended: true}));

app.get('/', function(req, res){
    res.sendFile(path.join(__dirname, 'static/index.html'));
})

app.get('/todoData', function(req, res){
    console.log('User asked for todo data');
    fs.readFile('data/data.json', function (err, file) {
        res.json(JSON.parse(file));
    });
});

app.post('/todoData', function(req, res){
    console.log('sending new todo data');
    fs.readFile('data/data.json', function (err, file) {
        let body = req.body;
        let todos = JSON.parse(file);
        todos.push({"what" : body.fwhat});
        fs.writeFile(path.join(__dirname, '/data/data.json'), JSON.stringify(todos, null, 4), function(err) {
            if(err) {
                return console.log(err);
            }
            console.log("The file was saved!");
        });
    });
    res.redirect('/');
});

app.listen(8000);
console.log("Page is available at localhost:8000")