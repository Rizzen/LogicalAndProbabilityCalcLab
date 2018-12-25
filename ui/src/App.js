import React, { Component } from 'react';
import logo from './index2.png';
import './App.css';
import Form from './Form.js';
import Menu from './Menu'

class App extends Component {
  render() {
    return (
      <div className="App">
          <div className="App-body">
              Структурно-функциональная схема надежности
              <img src={logo} alt="logo" />
              <Form />
          </div>
      </div>
    );
  }
}

export default App;
