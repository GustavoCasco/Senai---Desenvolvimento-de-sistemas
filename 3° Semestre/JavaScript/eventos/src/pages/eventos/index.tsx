import React, {useState, useEffect} from 'react';
import Header from '../../components/header';
import '../../Assets/style/global.css';
import Footer from '../../components/footer';

export default function Eventos(){
    
    const [filme,setfilme] = useState('');
    const [getfilmes,setfilmes] = useState([]);
    const [idfilmes,setId] = useState(0);

    const [ idgenero,setidgenero] = useState(0);
    const[generos, setgenero] = useState([])

    useEffect(() => {
        listarfIlmes();
        listargeneros();
    }, [])

    return(
        <div>
            <Header title="Registre seus Eventos"/>
            <h1>Eventos</h1>
            <Footer/>
        </div>
    );
}
