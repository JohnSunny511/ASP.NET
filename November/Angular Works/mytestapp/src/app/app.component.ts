import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ExamplecompComponent } from './examplecomp/examplecomp.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet,ExamplecompComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'mytestapp';
}
