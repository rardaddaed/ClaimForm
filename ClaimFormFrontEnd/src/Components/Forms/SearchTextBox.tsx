import {DetailedHTMLProps, FC, InputHTMLAttributes, KeyboardEvent, TextareaHTMLAttributes, useState} from "react";
import {OptionItem} from "../../Services/formSchemaService.ts";
import {SharedProperties} from "../../Types/SharedProperties.ts";

type InputAndTextArea = SharedProperties<
    DetailedHTMLProps<InputHTMLAttributes<HTMLInputElement>, HTMLInputElement>,
    DetailedHTMLProps<TextareaHTMLAttributes<HTMLTextAreaElement>, HTMLTextAreaElement>
>

interface SearchTextBoxProps extends InputAndTextArea {
    id: string
    items: OptionItem[]
    onItemSelected: (itemKey: string) => void
}

export const SearchTextBox: FC<SearchTextBoxProps> = ({id, items, onItemSelected, ...rest}) => {

    const [keyboardSelectedElementIndex, setKeyboardSelectedElementIndex] = useState(-1);

    const handleListItemClicked = (key: string) => {
        onItemSelected(key);
    }

    const handleKeyDown = (event: KeyboardEvent) => {
        if (event.key === 'ArrowUp') {
            // Handle the 'ArrowUp' key press
            console.log('Arrow Up pressed');
            setKeyboardSelectedElementIndex(x => {
                x--;
                if(x < 0)
                    x = items.length - 1;
                return x;
            });
        } else if (event.key === 'ArrowDown') {
            // Handle the 'ArrowDown' key press
            console.log('Arrow Down pressed');
            setKeyboardSelectedElementIndex(x => {
                x++;
                if(x >= items.length)
                    x = 0;
                return x;
            });
        } else if (event.key === 'Enter') {
            // Handle the 'Enter' key press
            handleListItemClicked(items[keyboardSelectedElementIndex].key);
        }
    };

    return (
        <>
            <input
                id={id}
                type="text"
                onKeyDown={handleKeyDown}
                {...rest}
            />
            {items && items.length > 0 ? (
                <div style={{position: "relative"}} >
                    <ul className="search-text-box">
                        {items.map((x, index) => (<li key={x.key} onMouseEnter={() => setKeyboardSelectedElementIndex(index)} style={{backgroundColor: keyboardSelectedElementIndex === index ? "#e3e3e3" : "white"}} onClick={() => handleListItemClicked(x.key)}>{x.key}</li>))}
                    </ul>
                </div>
            ) : null}
        </>
    )
}
/*


const ulStyle: CSSProperties = {
    listStyleType: "none",
    padding: "2px",
    border: "1px solid lightgrey",
    position: "absolute",
    width: "100%",
    top: -2,
    backgroundColor: "white",
    // borderBottomLeftRadius: 8,
    // borderBottomRightRadius: 8,
    borderRadius: 8,
    cursor: "pointer",
    zIndex: 4,
};
*/
