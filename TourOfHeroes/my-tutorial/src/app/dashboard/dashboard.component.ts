import { Component, OnInit } from '@angular/core'; // Why do we need to import OnInit? Component?
import { Hero } from '../hero';
import { HeroService } from '../hero.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent {
  heroes: Hero[] = [];

  constructor(private heroService: HeroService) { }
  ngOnInit(): void {
    this.getHeroes();
  }

  getHeroes(): void {
    this.heroService.getHeroes()
    .subscribe(heroes => this.heroes = heroes.slice(0, 4));
    // What does subscribe() do again? Part of observable. Calling subscribe is when getHeroes() starts its work(?)
    /*
    * defines what will be emitted by an Observable, and when it be will emitted. This means
    * that calling `subscribe` is actually the moment when Observable starts its work, not when it is created, as it is often
    * the thought.
    */
  }
}
