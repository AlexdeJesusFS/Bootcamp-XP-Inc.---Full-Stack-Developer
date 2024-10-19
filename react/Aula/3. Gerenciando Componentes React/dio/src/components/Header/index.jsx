import React from 'react'
import {
    Container, Row, Wrapper, FindInputContainer, Menu, MenuRight, Input
} from './styles'
import { Button } from '../Button'
import logo from '../../assets/logo-dio.png'

function Header() {
  return (
    <Wrapper>
        <Container>
            <Row>
                <img src={logo} alt='Logo da DIO' />
                <FindInputContainer>
                    <Input placeholder='Buscar...' />
                </FindInputContainer>
                <Menu>Live Code</Menu>
                <Menu>Global</Menu>
            </Row>
            <Row>
                <MenuRight href='#'>Home</MenuRight>
                <Button>Entrar</Button>
                <Button>Cadastrar</Button>
            </Row>
        </Container>
    </Wrapper>
  )
}

export { Header }
