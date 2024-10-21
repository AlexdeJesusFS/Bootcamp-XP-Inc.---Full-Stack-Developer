//import { Link } from "react-router-dom";
import { Button } from "../../components/Button";
import { Header } from "../../components/Header";
import { Input } from "../../components/Input";
import { Container, Wrapper, Column, Row, Title, TitleLogin, SubTitleLogin, CriarConta, EsqueciSenha } 
from "./styles";
import { MdEmail, MdLock } from "react-icons/md";
import { useNavigate } from "react-router-dom"

function Login() {

  const navigate = useNavigate();

  const handleClickSignIn = () => {
    navigate('/feed')
  }

  return (
    <>
      <Header />
      <Container>
        <Column>
          <Title>
            A plataforma para você aprender com experts, dominar  as principais tecnologias e entrar mais rápido nas empresas mais desejadas.
          </Title>
        </Column>
        <Column>
          <Wrapper>
            <TitleLogin>Faça o seu cadastro</TitleLogin>
            <SubTitleLogin>Make the change._</SubTitleLogin>
            <form>
              <Input placeholder="E-mail" leftIcon={<MdEmail />}/>
              <Input placeholder="Senha" type="password" leftIcon={<MdLock />}/>
              <Button variant="secondary" onClick={handleClickSignIn} type='button'>Entrar</Button>
            </form>
            <Row>
              <EsqueciSenha>Esqueci a minha senha</EsqueciSenha>
              <CriarConta>Criar uma conta</CriarConta>
            </Row>
          </Wrapper>
        </Column>
      </Container>
    </>
  )
}

export { Login }
