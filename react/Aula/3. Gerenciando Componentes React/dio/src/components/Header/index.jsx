import React from 'react'
import {
    Container, Row, Wrapper, FindInputContainer, Menu, MenuRight, Input, UserPicture
} from './styles'
import { Button } from '../Button'
import logo from '../../assets/logo-dio.png'

function Header({authenticate}) {
  return (
    <Wrapper>
        <Container>
            <Row>
                <img src={logo} alt='Logo da DIO' />
                {authenticate ? 
                    <>
                        <FindInputContainer>
                            <Input placeholder='Buscar...' />
                        </FindInputContainer>
                        <Menu>Live Code</Menu>
                        <Menu>Global</Menu>
                    </>
                : null}
            </Row>
            <Row>
                {authenticate ? 
                    <UserPicture src='https://avatars.githubusercontent.com/u/65736748?v=4'/>
                :
                    <>
                        <MenuRight href='#'>Home</MenuRight>
                        <Button>Entrar</Button>
                        <Button>Cadastrar</Button>
                    </>
                }
            </Row>
        </Container>
    </Wrapper>
  )
}

export { Header }
