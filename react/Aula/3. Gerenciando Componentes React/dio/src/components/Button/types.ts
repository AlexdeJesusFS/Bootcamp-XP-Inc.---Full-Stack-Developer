export interface IButton {
    variant?: 'primary' | 'secondary';
    children: React.ReactNode;
    onClick?: () => void;
    type?: string;
}

export interface IButtonStyled {
    $variant?: 'primary' | 'secondary';
}