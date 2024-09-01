
export const RecaptchaFake = () => {

    return (
        <div className="row form-group justify-content-center mt-2">
          <span id="Recaptcha">
            <div
                className="g-recaptcha"
                data-sitekey="6LcfvfIbAAAAAJd14fSnWCO2alpaJ4WMHUMQuKZU"
            >
              <div style={{width: 304, height: 78}}>
                <div>
                  <iframe
                      id="RecaptchaIFrame"
                      title="reCAPTCHA"
                      width={304}
                      height={78}
                      style={{border: 0}}
                      scrolling="no"
                      role="presentation"
                      name="a-3gm5bnx8onrj"
                      sandbox="allow-forms allow-popups allow-same-origin allow-scripts allow-top-navigation allow-modals allow-popups-to-escape-sandbox allow-storage-access-by-user-activation"
                      src="https://www.google.com/recaptcha/api2/anchor?ar=1&k=6LcfvfIbAAAAAJd14fSnWCO2alpaJ4WMHUMQuKZU&co=aHR0cDovL2xvY2FsaG9zdDo2MDU2OQ..&hl=en&v=rKbTvxTxwcw5VqzrtN-ICwWt&size=normal&cb=ja2jum1i2esn"
                  />
                </div>
                <textarea
                    id="g-recaptcha-response"
                    name="g-recaptcha-response"
                    className="g-recaptcha-response"
                    style={{
                        width: 250,
                        height: 40,
                        border: "1px solid rgb(193, 193, 193)",
                        margin: "10px 25px",
                        padding: 0,
                        resize: "none",
                        display: "none"
                    }}
                    defaultValue={""}
                />
              </div>
              <iframe style={{display: "none"}}/>
            </div>
          </span>
        </div>
    );
}
