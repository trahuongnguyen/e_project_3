"use strict";
(e,t,n)=>{
    n.d(t, {
        Z: ()=>c
    });
    var r = n(99402)
      , a = n(3179)
      , o = n.n(a)
      , s = n(80608)
      , i = n.n(s);
    class c extends r.Component {
        constructor(e) {
            super(e),
            this.toggle = e=>{
                "function" == typeof this.props.onToggle && this.props.onToggle(this.state.open, e),
                this.hasProp("open") || (this.animate(),
                this.setState((e=>({
                    open: !e.open
                }))))
            }
            ,
            i()(null !== e.header && void 0 !== e.header, "`header` should not be null or undefined"),
            i()(null !== e.body && void 0 !== e.body, "`body` should not be null or undefined"),
            this.state = {
                open: !!(this.hasProp("open") ? e.open : e.openInitially)
            }
        }
        UNSAFE_componentWillReceiveProps(e) {
            e.open !== this.props.open && (this.animate(),
            this.setState({
                open: !!e.open
            }))
        }
        render() {
            const {header: e, body: t, className: n} = this.props;
            return r.createElement("div", {
                className: o()("stardust-dropdown", n, {
                    "stardust-dropdown--open": this.state.open
                })
            }, r.createElement("div", {
                className: "stardust-dropdown__item-header",
                onClick: this.toggle
            }, e), r.createElement("div", {
                className: o()("stardust-dropdown__item-body", {
                    "stardust-dropdown__item-body--open": this.state.open
                }),
                ref: e=>this._body = e
            }, t))
        }
        hasProp(e) {
            return null != this.props[e]
        }
        animate() {
            const e = this._body;
            if (!e)
                return;
            const {open: t} = this.state;
            let n;
            if (t) {
                const t = e.getBoundingClientRect().height;
                e.style.height = `${t}px`,
                e.style.opacity = "1",
                e.classList.remove("stardust-dropdown__item-body--open"),
                n = 0
            } else
                e.classList.add("stardust-dropdown__item-body--open"),
                n = e.getBoundingClientRect().height,
                e.style.height = "0px",
                e.style.opacity = "0";
            e.addEventListener("transitionend", (function() {
                e.style.height = ""
            }
            )),
            e.getBoundingClientRect(),
            requestAnimationFrame((()=>{
                e.style.height = `${n}px`,
                e.style.opacity = t ? "0" : "1"
            }
            ))
        }
    }
}
// var startdust = document.querySelectorAll('.stardust-dropdown');
// for(i=0; i<startdust.length; i++){
//     startdust[i].addEventListener('click', function handleClick() {
//         startdust[i].classList.add('stardust-dropdown--open');
//     });
// }
