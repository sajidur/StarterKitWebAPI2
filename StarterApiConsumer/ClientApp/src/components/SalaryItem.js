import React, { Component } from 'react';
export class SalaryItem extends Component {
    static displayName = SalaryItem.name;

    constructor(props) {
        super(props);
        this.state = { currentCount: 0 };
        this.incrementCounter = this.incrementCounter.bind(this);
    }

    incrementCounter() {
        this.setState({
            currentCount: this.state.currentCount + 1
        });
    }

    render() {
        return (
            <div>
                <h3>Salary Item Add</h3>
                <div class='row'>
                    <div class='col-md-6'>
                        <h3>Add Rules</h3>
                        <form>
                            <input name="benifitName" type="text" required />
                            <input name="benifitAmount" type="number" required />
                        </form>
                    </div>
                    <div class='col-md-6'>
                        <h3>Conditions</h3>

                    </div>
                    </div>
                <p aria-live="polite">Current count: <strong>{this.state.currentCount}</strong></p>

                <button className="btn btn-primary" onClick={this.incrementCounter}>Increment</button>
            </div>
        );
    }
}