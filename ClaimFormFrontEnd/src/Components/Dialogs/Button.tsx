import {ButtonHTMLAttributes} from "react";

interface ButtonProps extends ButtonHTMLAttributes<HTMLButtonElement> {
    label: string;
    icon?: string
}

const Button = ({label, icon, className = "", ...rest}: ButtonProps) => {
    return (
        <button type="button" role="button" className={"btn " + className} {...rest} >
            {icon ? <i className={`fa ${icon} fa-lg me-1`} aria-hidden="true"/> : null}
            {label}
        </button>
    );
};

export default Button;
