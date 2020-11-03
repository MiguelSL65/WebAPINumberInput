import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Counter } from './components/Counter';
import { Form } from './components/Form/Form';
import { SumForm } from './components/Form/SumForm';

import './custom.css'

export const App = () => {

    return (
      <Layout>
        <Route exact path='/addnum' component={Form} />
        <Route path='/sum' component={SumForm} />
      </Layout>
    );
}
