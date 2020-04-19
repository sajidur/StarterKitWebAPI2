import React, { Component } from 'react';
import axios from 'axios';

export class SalaryItem extends Component {
    static displayName = SalaryItem.name;
    state = {
        benifitName: '',
        benifitAmount:''
    }
    constructor(props) {
        super(props);
        this.state = { benifitName: 'test', benifitAmount: 100 };
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }
    handleChange = (event) => {
        this.setState({ [event.target.name]: event.target.value });
    }
    handleSubmit(event) {
        event.preventDefault();
        var request = { ItemName: this.state.benifitName, Amount: this.state.benifitAmount };
        axios.post('https://localhost:44334/api/SalaryItem', request)
            .then(res => {
                console.log(res);
                console.log(res.data);
            });
    }

    render() {
        return (
            <div>
                <h3>Salary Item Add</h3>
                <div className='row'>
                    <div className='col-md-6'>
                        <h3>Add Rules</h3>
                        <form onSubmit={this.handleSubmit}>
                            <input name="benifitName" value={this.state.value} type="text" required onChange={this.handleChange} />
                            <input name="benifitAmount" value= {this.state.value} type="number" required onChange={this.handleChange} />
                            <input type="submit" value="Submit" />
                        </form>
                    </div>
                    <div className='col-md-6'>
                        <h3>Conditions</h3>

                    </div>
                    </div>

            </div>
        );
    }
}