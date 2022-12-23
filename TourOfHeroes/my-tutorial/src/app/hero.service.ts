import { Injectable } from '@angular/core';
import { Hero } from './hero';
import { HEROES } from './mock-heroes';
import { Observable, of } from 'rxjs';
import { MessageService } from './message.service';

@Injectable({
  providedIn: 'root'
})
export class HeroService {

  constructor(private messageService: MessageService) { }

  // Getter
  getHeroes(): Observable<Hero[]> { // Get list of heroes asynchronously
    const heroes = of(HEROES); // 'of' returns Observable<T>
    this.messageService.add('HeroService: fetched heroes');
    return heroes;
  }
}
