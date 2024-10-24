import { ButtonContainer } from './styles'
import { IButton } from './types'

function Button({variant="primary", onClick, children}: IButton) {
  return (
    <ButtonContainer $variant={variant} onClick={onClick}>
      {children}
    </ButtonContainer>
  )
}

export { Button }