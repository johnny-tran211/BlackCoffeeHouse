import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-auth",
  templateUrl: "./auth.component.html",
  styleUrls: ["./auth.component.css"]
})
export class AuthComponent implements OnInit {
  constructor() {}

  ngOnInit() {}
  login(form) {
    console.log(form.value.username);
    console.log(form.value.password);
  }
}
