  create database BuhtigSourceControl;
use BuhtigSourceControl;
create table Users
(
  id int auto_increment primary key,
  username varchar(30) not null unique,
  password varchar(30) not null,
  email varchar(50) not null
);
create table Repositories
(
  id int auto_increment primary key,
  name varchar(50) not null
);
create table Repositories_Contributors
(
  repository_id int,
  constraint fk_repositoryID_repositories_contributors
  foreign key (repository_id)
  references Repositories(id),
  contributor_id int,
  constraint fk_contributorID_repositories_contributors
  foreign key (contributor_id)
  references Users(id)
);
create table Issues
(
  id int auto_increment primary key,
  title varchar(255) not null,
  issue_status varchar(6) not null,
  repository_id int not null,
  constraint fk_repository_ID_issues
  foreign key (repository_id)
  references Repositories(id),
  assignee_id int not null,
  constraint fk_assigneeID_issues
  foreign key (assignee_id)
  references Users(id)
);
create table Commits
(
  id int auto_increment primary key,
  message varchar(255) not null,
  issue_id int,
  constraint fk_issueID_commits
  foreign key (issue_id)
  references Issues(id),
  repository_id int not null,
  constraint fk_repositoryID_commits
  foreign key (repository_id)
  references Repositories(id),
  contributor_id int not null,
  constraint fk_contributorID_commits
  foreign key (contributor_id)
  references Users(id)
);
create table Files
(
  id int auto_increment primary key,
  name varchar(100) not null,
  size double(10,2) not null,
  parent_id int,
  constraint fk_parentID_files
  foreign key (parent_id)
  references Files(id),
  commit_id int not null,
  constraint fk_commitID_files
  foreign key (commit_id)
  references Commits(id)
);
    
    
  
  

