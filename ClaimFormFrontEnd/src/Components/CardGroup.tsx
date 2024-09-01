import {FC, PropsWithChildren} from "react";

interface CardGroupProps {
    text: string
    id?: string
    isVisible?: () => boolean
    marginBottom?: number
    paddingContainer?: boolean
}

export const CardGroup: FC<PropsWithChildren<CardGroupProps>> = ({children, text, id, paddingContainer = false, marginBottom = 30, isVisible = () => true}) => {

    if(!isVisible())
        return null;

    return (
        <>
            <fieldset
                id={id}
                className="card border-primary "
                style={{marginBottom: marginBottom}}
            >
                <legend className="card-header bg-primary text-white">
                    {text}
                </legend>
                <div className="card-body">
                    <div className={paddingContainer ? "padding-container" : ""}>
                        {children}
                    </div>
                </div>
            </fieldset>
        </>
    );

}
