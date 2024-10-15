import './style.css'

export default function Input(props) {
    return (
        <input 
            placeholder={props.placeholder}
            onChange={props.onChange}
            value={props.value}
        />
    )
}