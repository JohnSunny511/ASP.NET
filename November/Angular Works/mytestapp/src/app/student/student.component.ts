import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-student',
  imports: [CommonModule],
  templateUrl: './student.component.html',
  styleUrl: './student.component.css'
})
export class StudentComponent {

  amount = 123.45;
  company = 'acme corporation';
  purchasedOn = '2024-07-08';
  scheduledOn = '2026-12-25';
}
