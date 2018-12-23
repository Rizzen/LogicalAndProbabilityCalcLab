import React from 'react';
import './App.css';

class Form extends React.Component {
    constructor(props) {
        super(props);
        this.state = {value: '', intensity : 0, moment : 0, result : 0};

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleChange(event) {
        this.setState({result: 10});
    }

    handleSubmit(event) {
        alert('A name was submitted: ' + this.state.value);
        event.preventDefault();
    }

    handleIntensityChange(evt){
        this.setState({intensity : evt.target.value})
    }

    handleMomentChange(evt){
        this.setState({moment : evt.target.value})
    }

    render() {
        return (
            <form onSubmit={this.handleSubmit}>

                <div className="section">
                    <div className="section-item">
                        Интенсивность отказов:
                        <input type="text" onChange={event => this.handleIntensityChange(event)}/>

                        Момент времени:
                        <input type="text" onChange={event => this.handleMomentChange(event)}/>
                    </div>
                    <div className="section-item">
                        <label>Вероятность работы системы = {this.state.intensity}</label>
                        <input type="submit" value="Рассчитать" />
                    </div>
                </div>
            </form>
        );
    }
}

export default Form;