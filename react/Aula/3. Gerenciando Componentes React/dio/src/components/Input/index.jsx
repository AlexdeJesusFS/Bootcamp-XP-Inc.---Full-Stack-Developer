import {InputContainer, IconContainer, InputText} from './styles'
import React from 'react'

function Input({leftIcon, name, ...rest}) {
  return (
    <InputContainer>
        {leftIcon ? <IconContainer>{leftIcon}</IconContainer> : null}
        <InputText name={name} {...rest} />
    </InputContainer>
  )
}

export { Input }