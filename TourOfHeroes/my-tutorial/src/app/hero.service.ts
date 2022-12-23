import { Injectable } from '@angular/core';
import { Hero } from './hero';
import { HEROES } from './mock-heroes';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HeroService {

  constructor() { }

  // Getter
  getHeroes(): Observable<Hero[]> { // Get list of heroes asynchronously
    const heroes = of(HEROES); // 'of' returns Observable<T>
    return heroes;
  }
}
