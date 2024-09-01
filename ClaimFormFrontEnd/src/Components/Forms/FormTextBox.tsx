import {DetailedHTMLProps, FC, InputHTMLAttributes, TextareaHTMLAttributes} from "react";
import {SbcLabel} from "../SbcLabel.tsx";
import {useFormContext} from "react-hook-form";
import {callback, FormContext} from "../../Services/formSchemaService.ts";
import {SharedProperties} from "../../Types/SharedProperties.ts";
import {mergeFormSchema} from "./Utils.ts";
import {SearchTextBox} from "./SearchTextBox.tsx";

type InputAndTextArea = SharedProperties<
    DetailedHTMLProps<InputHTMLAttributes<HTMLInputElement>, HTMLInputElement>,
    DetailedHTMLProps<TextareaHTMLAttributes<HTMLTextAreaElement>, HTMLTextAreaElement>
>

interface FormTextBoxProps extends InputAndTextArea {
    id: string
    label: string
    isVisible?: () => boolean
    multiline?: boolean
    onDependentFieldChanged?: () => (false | {shouldSet: boolean, newValue: string | number | object | boolean})
}

export const FormTextBox: FC<FormTextBoxProps> = ({id, label, isVisible = () => true, multiline = false, onDependentFieldChanged, ...rest}) => {

    const methods = useFormContext() as FormContext;
    const {
        register,
        schema,
        formName,
        formState: { errors },
        setValue,
    } = methods;

    const idLowerCase = id.toLowerCase();

    const handleCallback = async (newValue: string | number | object | boolean) => {
        const schemaToMerge = await callback(formName, {fieldName: idLowerCase, value: newValue})
        mergeFormSchema(schemaToMerge, methods.setSchema, setValue);
        console.log("dependent field changed so setting value to", newValue)
        setValue(idLowerCase, newValue);
    }

    if(onDependentFieldChanged){
        const change = onDependentFieldChanged();
        if(change && change.shouldSet) {
            handleCallback(change.newValue);
        }
    }

    if(!isVisible())
        return null;

    const enabled = schema[idLowerCase]?.enabled ?? false;
    const mandatory = schema[idLowerCase]?.mandatory ?? false;
    const maxLength = schema[idLowerCase]?.maxLength;
    const hasError = !!errors[idLowerCase];
    const hasCallback = schema[idLowerCase]?.callback;

    const extraClasses = rest.className ?? "";

    const suburbFields = schema[idLowerCase]?.suburbDefinition;
    if((idLowerCase.endsWith("suburb") || idLowerCase.startsWith("suburb")) && suburbFields){
        const items = schema[idLowerCase]?.items ?? [];
        return (
            <>
                <SbcLabel text={label} associatedControlID={idLowerCase} hasError={hasError}/>
                <SearchTextBox
                    items={items}
                    onItemSelected={(itemKey) => {
                        const words = itemKey.trim().split(/\s+/);

                        // Extract the last two words
                        const lastWord = words.slice(-1).join(' ');
                        const secondLastWord = words.slice(-2, -1).join(' ');

                        // Extract the rest of the string
                        const restOfString = words.slice(0, -2).join(' ');

                        // console.log("Setting value for", suburbFields[1], "to", lastWord)
                        setValue(suburbFields[0], restOfString);
                        setValue(suburbFields[1], secondLastWord);
                        setValue(suburbFields[2], lastWord);
                        const copySchema = {...schema};
                        copySchema[idLowerCase].items = undefined;
                        mergeFormSchema(copySchema, methods.setSchema, setValue);
                    }}
                    id={idLowerCase}
                    maxLength={maxLength}
                    disabled={!enabled}
                    {...rest}
                    className={"form-control auto-grow Text" + (mandatory ? " Mandatory" : "") + ` ${extraClasses}`}
                    {...register(idLowerCase, {
                        required: mandatory,
                        onChange: async (event) => {
                            const schemaToMerge = await callback(formName, {fieldName: idLowerCase, value: event.target.value})
                            mergeFormSchema(schemaToMerge, methods.setSchema, setValue);
                        }
                    })}
                />
            </>
        )
    }

    if(idLowerCase.endsWith("date") || idLowerCase.startsWith("date")){
        return (
            <>
                <SbcLabel text={label} associatedControlID={idLowerCase} hasError={hasError}/>
                <div className="input-group date" data-provide="datepicker" data-date-autoclose="true" data-date-format="dd/mm/yyyy" data-date-enable-on-readonly="false" data-date-today-btn="linked" data-date-force-parse="false" data-date-today-highlight="true">
                    <input
                        id={idLowerCase}
                        type="date"
                        maxLength={maxLength}
                        disabled={!enabled}
                        tabIndex={0}
                        {...rest}
                        className={"form-control auto-grow Date" + (mandatory ? " Mandatory" : "") + ` ${extraClasses}`}
                        {...register(idLowerCase, {
                            required: mandatory,
                            onBlur: hasCallback ? async (event) => {
                                const schemaToMerge = await callback(formName, {fieldName: idLowerCase, value: event.target.value})
                                mergeFormSchema(schemaToMerge, methods.setSchema, setValue);
                            } : undefined
                        })}
                    />
                    {/*<i className="fa fa-calendar input-group-text add-on" aria-hidden="true"></i>*/}
                </div>
            </>
        )
    }

    if(multiline){
        return (
            <>
                <SbcLabel text={label} associatedControlID={idLowerCase} hasError={hasError}/>
                <textarea
                    id={idLowerCase}
                    rows={2}
                    cols={20}
                    placeholder="(e.g. broken left lower leg, dermatitis of the hands, lower back strain)"
                    maxLength={10000}
                    disabled={!enabled}
                    style={{overflow: "hidden", resize: "none", height: "60px"}}
                    {...rest}
                    className={"form-control auto-grow Text" + (mandatory ? " Mandatory" : "") + ` ${extraClasses}`}
                    {...register(idLowerCase, {
                        required: mandatory,
                        onBlur: hasCallback ? async (event) => {
                            const schemaToMerge = await callback(formName, {fieldName: idLowerCase, value: event.target.value})
                            mergeFormSchema(schemaToMerge, methods.setSchema, setValue);
                        } : undefined
                    })}
                />
            </>
        );
    }

    return (
        <>
            <SbcLabel text={label} associatedControlID={idLowerCase} hasError={hasError}/>
            <input
                id={idLowerCase}
                type="text"
                maxLength={maxLength}
                disabled={!enabled}
                {...rest}
                className={"form-control auto-grow Text" + (mandatory ? " Mandatory" : "") + ` ${extraClasses}`}
                {...register(idLowerCase, {
                    required: mandatory,
                    onBlur: hasCallback ? async (event) => {
                        const schemaToMerge = await callback(formName, {fieldName: idLowerCase, value: event.target.value})
                        mergeFormSchema(schemaToMerge, methods.setSchema, setValue);
                    } : undefined
                })}
            />
        </>
    )
}
