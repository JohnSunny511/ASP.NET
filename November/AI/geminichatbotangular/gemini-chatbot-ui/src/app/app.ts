import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ChatService } from './services/chat.service';
import { finalize } from 'rxjs';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {

  message = '';
  chats: any[] = [];
  loading = false;

  constructor(private chatService: ChatService) {}

  sendMessage() {

    if (!this.message.trim() || this.loading) return;

    const userMessage = this.message;

    this.chats.push({
      role: 'user',
      text: userMessage
    });

    this.message = '';
    this.loading = true;

    this.chatService.sendMessage(userMessage)
      .pipe(
        finalize(() => this.loading = false)
      )
      .subscribe({

        next: (res) => {

  console.log('Gemini Response:', res);

  this.chats.push({
    role: 'gemini',
    text: res.response
  });

  console.log('Chat messages:', this.chats);
},

        error: (err) => {

          console.error('API Error:', err);

          this.chats.push({
            role: 'gemini',
            text: 'Unable to connect to Gemini. Please try again.'
          });

        }

      });
  }
}