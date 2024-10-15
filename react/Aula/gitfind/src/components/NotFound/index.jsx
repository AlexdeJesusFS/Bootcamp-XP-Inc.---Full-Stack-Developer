import './style.css'
import NotFoundImage from '../../assets/img404.png'

export default function NotFound({message}) {
  return (
    <div className='NotFound'>
        <h2 className='message'>{message}</h2>
        <img className='img404' src={NotFoundImage} alt='Not Found'/>
    </div>
  )
}
