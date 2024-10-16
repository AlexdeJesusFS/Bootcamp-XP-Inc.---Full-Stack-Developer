import './style.css'

export default function ListItem({key, title, description}) {
  return (
    <div className='list-item'>
      <p hidden>{key}</p>
      <strong>{title}</strong>
      <p>{description}</p>
      <hr/>
    </div>
  )
}
