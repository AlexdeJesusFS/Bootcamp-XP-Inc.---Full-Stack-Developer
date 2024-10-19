//import { Link } from "react-router-dom";
import { Button } from "../../components/Button";
import { Header } from "../../components/Header";
import { Container, Title, TitleHighLight, TextContent } from "./styles"
import banner from '../../assets/banner.png'

function Home() {
  return (
    <>
        <Header />
        <Container>
          <div>
            <Title>
              <TitleHighLight>
              Implemente
              <br />
              </TitleHighLight>
              o seu futuro global agora!
            </Title>
            <TextContent>
              Domine as tecnologias utilizadas pelas empresas mais inovadoras do mundo e encare seu novo desafio profissional, evoluindo em comunidade com os melhores experts.
            </TextContent>
            <Button variant="secondary" onClick={() => null}>Comece agora!</Button>

          </div>
          <div>
            <img src={banner} alt='Imagem principal, homem com tablet e mensagens flutuantes em volta'/>
          </div>
        </Container>
    </>
  )
}

export { Home }
