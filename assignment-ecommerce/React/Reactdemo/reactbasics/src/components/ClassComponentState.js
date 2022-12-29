import React, { Component } from "react"
export class ClassComponentState extends Component {
    state = { value: 0 }
    UpdateState = () => this.setState({ value: (this.state.value + 1) })
    render() {
        return (
            <div>
                <h1>State: No of clicks {this.state.value}</h1>
                <button onClick={this.UpdateState}>Click</button>
            </div>
        )
    }
}