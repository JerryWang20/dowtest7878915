import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { Router } from '@angular/router';
import { Adal5Service } from 'adal-angular5';
import { MenuService } from '../menu.service';


@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.scss']
})
export class ToolbarComponent implements OnInit {

  public userName: string;
  public title: string;
  @Output() toggleSidenav = new EventEmitter<void>();

  constructor(
    private router: Router,
    private adalService: Adal5Service,
    private menuService: MenuService) {
      this.router = router;
      this.menuService.pageTitle$.subscribe(
        data => {
          this.title = data;
        });

  }

  ngOnInit() {

    if (this.adalService.userInfo) {
      setTimeout(() => {
        this.userName = this.adalService.userInfo.profile.name;
      }, 500);
    }

  }
}
