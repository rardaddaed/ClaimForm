namespace SAOCPSEDB.ClaimForm.Forms
{
    public class CallbackDto
    {
        public CallbackDto() { }

        public CallbackDto(string fieldName, object value)
        {
            FieldName = fieldName;
            Value = value;
        }

        public string FieldName { get; set; }
        public object Value { get; set; }
    }

    public class SubmitForm
    {
        public CallbackDto[] FormFields { get; set; }
    }
}
