import { Container, NameText, Progress, UserPicture } from './styles'
import { IUserInfo } from './types'


function UserInfo({name, image, percentual}: IUserInfo) {
  return (
    <Container>
        <UserPicture src={image} />
        <div>
            <NameText>{name}</NameText>
            <Progress percentual={percentual} />
        </div>
    </Container>
  )
}

export { UserInfo }
