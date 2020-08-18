import 'dart:async';
import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;



Future<User> fetchUser() async {
  final response =
      await http.get('http://192.168.178.20:28656/api/V1/Users/2');

  if(response.statusCode == 200){
    return User.fromJson(json.decode(response.body));
  }
  else{
    throw Exception(response.body);
  }
}

class User{
  final int ovNummer;
  final String firstName;
  final String lastName;

  User({this.ovNummer, this.firstName, this.lastName});

  factory User.fromJson(Map<String, dynamic> json){
    return User(
      ovNummer: json['ovNummer'],
      firstName: json['firstName'],
      lastName: json['lastName']
    );
  }
}
void main() => runApp(MyApp());

class MyApp extends StatefulWidget {
  MyApp({Key key}) : super(key: key);

  @override
  _MyAppState createState() => _MyAppState();
}

class _MyAppState extends State<MyApp> {
  Future<User> futureUser;

  @override
  void initState() {
    super.initState();
    futureUser = fetchUser();
  }

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Fetch Data Example',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: Scaffold(
        appBar: AppBar(
          title: Text('Fetch Data Example'),
        ),
        body: Center(
          child: FutureBuilder<User>(
            future: futureUser,
            builder: (context, snapshot) {
              if (snapshot.hasData) {
                return Text(snapshot.data.firstName);
              } else if (snapshot.hasError) {
                return Text("${snapshot.error}");
              }

              // By default, show a loading spinner.
              return CircularProgressIndicator();
            },
          ),
        ),
      ),
    );
  }
}