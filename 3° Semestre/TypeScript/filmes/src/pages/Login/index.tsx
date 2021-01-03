import React from 'react';
import Header from '../../components/Header';
import Footer from '../../components/Footer';
import Input from './../../components/input/index'

function Login() {
  return (
    <div className="Login">
      <Header description='Faça o login e acesse a coletanea'/>
      <div className="centro"></div>
      <div className='Login'></div>
      <h1>Login</h1>
      <Input name='Senha' label="Senha"/>
      <Input type="password" label="asd"/>
      <Footer/>
    </div>
  );
}

export default Login;