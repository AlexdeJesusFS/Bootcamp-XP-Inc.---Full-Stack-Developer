import React from "react";

export interface IInput extends React.InputHTMLAttributes<HTMLInputElement> {
    name: string;
    leftIcon?: React.ReactNode;
    control?: any;
    errorMessage?: string;
    [key: string]: any; // Para aceitar outras propriedades extras como 'rest'
}