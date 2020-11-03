import React from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import { Layout } from './components/Layout/Layout';
import { Home } from './components/Layout/Home';
import { Form } from './components/Form/Form';
import { SumForm } from './components/Form/SumForm';
import { NumTable } from './components/Data/NumTable';
import { NotFound } from './NotFound';
import './custom.css'

export const App = () => {

    return (
      <BrowserRouter>
        <Layout>
          <Switch>
            <Route exact path='/' component={Home}/>
            <Route exact path='/addnum' component={Form} />
            <Route exact path='/sum' component={SumForm} />
            <Route exact path='/getall' component={NumTable} />
            <Route component={NotFound} />
          </Switch>
        </Layout>
      </BrowserRouter>
    );
}
