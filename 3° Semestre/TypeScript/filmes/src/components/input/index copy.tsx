import  React , { InputHTMLAttributes, Component } from 'react';

interface inputProps extends InputHTMLAttributes<HTMLInputElement> {
    label:string;
    name?:string;
}

const Input:React.FC<inputProps> = ({label, name, ...rest}) => {
    return  (
        <div>
            <label htmlFor={name}>{label}</label><br/>
            <input type ='text' id={name}/>
        </div>
    )
    
}

export default Input