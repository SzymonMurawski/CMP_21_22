
var http = require('http');
var url = require('url');
var path = require('path');
var fs = require('fs');
const express = require('express');
const mongo = require('mongodb');

var mongoClient = mongo.MongoClient;
var mongoUrl = "mongodb://localhost:27017";

mongoClient.connect(mongoUrl, function(err, db) {
  if (err) throw err;
  console.log("Connected to the database");
  db.close();
});


const app = express();
app.use(express.static('static'));
app.use(express.urlencoded({extended: true}));

app.get('/', function(req, res){
    res.sendFile(path.join(__dirname, 'static/index.html'));
})

app.get('/todoData', function(req, res){
    console.log('User asked for todo data');
    mongoClient.connect(mongoUrl, function(err, db) {
        if (err) throw err;
        var dbo = db.db("tododb2");
        dbo.collection("todos").find({}).toArray(function(err, result) {
            if (err) throw err;
            console.log(result);
            res.json(result);
        });
    });
});

app.post('/todoData', function(req, res){
    console.log('sending new todo data');
    
    let body = req.body;
    let newTodo = {"what" : body.fwhat};
    mongoClient.connect(mongoUrl, function(err, db) {
        if (err) throw err;
        var dbo = db.db("tododb2");
        dbo.collection("todos").insertOne(newTodo, function(err, res) {
            if (err) throw err;
            console.log("1 document inserted");
            db.close();
        });
    });

    res.redirect('/');
});

app.listen(8000);
console.log("Page is available at localhost:8000")