import React from 'react'
import { ButtonContainer } from './styles.js'

function Button({title, variant="primary", onClick}) {
  return (
    <ButtonContainer variant={variant} title={title} onClick={onClick}>
    </ButtonContainer>
  )
}

export default Button