import {InputContainer, IconContainer, InputText, ErrorMessage} from './styles'
import { Controller } from 'react-hook-form'
import { IInput } from './types'
 
function Input({name, leftIcon, control, errorMessage, ...rest}: IInput) {
  return (
    <>
      { errorMessage ? <ErrorMessage>{errorMessage}</ErrorMessage> : null }
      <InputContainer>
          {leftIcon ? <IconContainer>{leftIcon}</IconContainer> : null}
          <Controller 
          name={name}
          control={control}
          rules={{ required: true }}
          render={({ field }) => <InputText {...field} {...rest} />} 
          />
      </InputContainer>
    </>
  )
}

export { Input }