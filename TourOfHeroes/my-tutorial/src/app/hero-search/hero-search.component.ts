import { Component, OnInit } from '@angular/core';
import { Observable, Subject } from 'rxjs';
import {
  debounceTime, distinctUntilChanged, switchMap
} from 'rxjs/operators';

import { Hero } from '../hero';
import { HeroService } from '../hero.service';

@Component({
  selector: 'app-hero-search',
  templateUrl: './hero-search.component.html',
  styleUrls: ['./hero-search.component.scss']
})

export class HeroSearchComponent implements OnInit{
  heroes$!: Observable<Hero[]>;
  // Subject is both a source of observables and an observable itself
  private searchTerms = new Subject<string>();

  constructor(private heroService: HeroService) {}

  search(term: string): void {
    // Push values into observable
    this.searchTerms.next(term);
  }

  ngOnInit(): void {
    this.heroes$ = this.searchTerms
      .pipe(
        debounceTime(300), // Wait a 300ms after each keystroke before considering term
        distinctUntilChanged(), // Ignore new term if same as previous term
        // Switch to new search observable each time ther term changes
        switchMap((term: string) => this.heroService.searchHeroes(term)),
      );
  }
}
