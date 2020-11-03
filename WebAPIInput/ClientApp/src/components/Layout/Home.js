import React, { Component } from 'react';
import { Link } from 'react-router-dom';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1 className='h1'>Welcome.</h1>
        <div id='home'>
        <p>Welcome to our single-page application. Here you can:</p>
        <p id='features'>Add numbers to the database, by clicking <Link to='/addnum'>here</Link>. Alternatively you can use the navigation menu on the top of the page.</p>
        <p id='features'>Sum numbers, by providing existing indexes in our database, by clicking <Link to='/sum'>here</Link>.</p>
        <p id='features'>You can see the list of numbers in the database. If you get an error in this page, please add some numbers to DB first.</p>
        <p id='built-in'>This application was built using the following technologies:</p>
        <ul>
          <li><b>ASP.NET Core</b> and <b>C#</b> for cross-platform server-side code.</li>
          <li><b>MySQL</b> as the relational database management system.</li>
          <li><b>React</b> for client-side code.</li>
          <li><b>HTML</b> and <b>CSS</b> for layout and styling.</li>
        </ul>
      </div>
      </div>
    );
  }
}
