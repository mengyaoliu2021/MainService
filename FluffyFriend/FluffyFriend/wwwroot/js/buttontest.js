const { Stack, IStackTokens, CompoundButton, ThemeProvider, initializeIcons } = window.FluentUIReact;

// Initialize icons in case this example uses them
initializeIcons();

interface IButtonExampleProps {
    // These are set based on the toggles shown above the examples (not needed in real code)
    disabled?: boolean;
    checked?: boolean;
}

// Example formatting
const stackTokens: IStackTokens = { childrenGap: 40 };

const ButtonCompoundExample: React.FunctionComponent<IButtonExampleProps> = props => {
    const { disabled, checked } = props;

    return (
        <Stack horizontal tokens = { stackTokens } >
            <CompoundButton secondaryText="This is the secondary text." disabled = { disabled } checked = { checked } >
                Standard
                < /CompoundButton>
                < CompoundButton primary secondaryText = "This is the secondary text." disabled = { disabled } checked = { checked } >
                    Primary
                    < /CompoundButton>
                    < /Stack>
  );
};

const ButtonCompoundExampleWrapper = () => <ThemeProvider><ButtonCompoundExample /></ThemeProvider >;
ReactDOM.render(<ButtonCompoundExampleWrapper />, document.getElementById('content'))