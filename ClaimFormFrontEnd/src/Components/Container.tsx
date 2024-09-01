import React, {PropsWithChildren} from "react";


// React.DetailedHTMLProps<React.HTMLAttributes<HTMLDivElement>, HTMLDivElement>

interface ContainerProps extends React.HTMLProps<HTMLElement> {
    isVisible?: () => boolean
    type?: "div" | "span" | "fragment"
}

const elementTypeMap: { [key: string]: keyof React.ReactHTML | typeof React.Fragment } = {
    fragment: React.Fragment,
};

const Container = ({isVisible, children, type = "div", ...props}: PropsWithChildren<ContainerProps>) => {

    if(isVisible && !isVisible())
        return null;

    return React.createElement(elementTypeMap[type] || type, props, children);
};

export default Container;
