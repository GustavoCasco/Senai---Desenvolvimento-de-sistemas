import React, {useState} from 'react';
import Header from '../../components/header';
import '../../Assets/style/global.css';
import Footer from '../../components/footer';
import Input from '../../components/input';
import Button from '../../components/button';
import {useHistory} from 'react-router-dom'

export default function Login(){

    let history = useHistory();

    const [email, setEmail] = useState('');
    const [senha,setSenha] = useState('');

    const login = () => {
        const login = {
            email:email,
            senha:senha
        }
        
        fetch('http://localhost:5000/api/Conta/login', {
            method: 'POST',
            body: JSON.stringify(login),
            headers: {
                'content-type': 'application/json'
            }
        })
        
        .then(response => response.json())
        .then(dados => {
            localStorage.setItem('token' , dados.token);
            history.push('/')
        })
        .catch(erro => console.error(erro))
    }
        
        
        return(
            <div>
            <Header title="Acesse todos os Eventos"/>
            <h1>Login</h1>
            <div className='centro'>
                <form onSubmit={event => {
                    event.preventDefault();
                    login();

                }} >
                    <Input name='email' label = 'E-mail' onChange={e => setEmail(e.target.value)}/>
                    <Input name='senha' label = 'Senha' onChange={e => setSenha(e.target.value)}/>
                    <Button value ='Enviar'/>
                </form>
            </div>
            <Footer/>
        </div>
    );
}

