import {DetailedHTMLProps, FC, Fragment, InputHTMLAttributes} from "react";
import {OptionItem} from "../Services/formSchemaService.ts";

export interface SbcRadioButtonListProps extends DetailedHTMLProps<InputHTMLAttributes<HTMLInputElement>, HTMLInputElement> {
    id: string
    isMandatory?: boolean
    items: OptionItem[]
}

export const SbcRadioButtonList: FC<SbcRadioButtonListProps> = ({id, items, isMandatory = false, ...rest}) => {

    return (
        <span id={id} className={"radio-button-list " + (isMandatory ? "Mandatory" : "")}>
            {items.map((item, i) => (
                <Fragment key={`${id}_${item.key}_${i}`}>
                    <input
                        id={`${id}_${i}`}
                        type="radio"
                        name={`$${id}`}
                        defaultValue={item.key}
                        {...rest}
                    />
                    <label htmlFor={`${id}_${i}`} id={`${id}_${i}:label`}>
                        {item.value}
                    </label>
                </Fragment>
            ))}
        </span>
    )
}
