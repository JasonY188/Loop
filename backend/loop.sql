CREATE TABLE JobList(
    joblist_id                       SERIAL PRIMARY KEY,
    post_date                        varchar(200),
    company_name                     varchar(200),
    job_title                        varchar(200),
    job_requirement                  varchar(200),
    contact_person                   varchar(200)
   
);

CREATE TABLE LoopUser(
    loop_user_id                    SERIAL PRIMARY KEY,
    name                            varchar(200),
    password                        varchar(200),
    email                           varchar(200)

);

CREATE TABLE JobApply(
    jobapply_id                      SERIAL PRIMARY KEY,
    date_apply                       varchar(200),
    date_respond                     varchar(200),
    move_forward                     boolean,
    phone_interview_date             varchar(200),
    first_interview_date             varchar(200),
    second_interview_date            varchar(200),
    third_interview_date             varchar(200),
    offer_date                       varchar(200),
    acceptance                       boolean,
    joblist_id                       integer REFERENCES JobList (joblist_id),
    loop_user_id                     integer REFERENCES LoopUser (loop_user_id)
);

INSERT INTO JobList( post_date, company_name, job_title, job_requirement, contact_person)
VALUES
('2018-10-30', 'ABC Company', 'Full Stack Developer', 'React, React Native, C#, PostgreSQL', 'Jerry Jones' ),
('2018-11-01', 'ABC Company', 'Software Developer', 'React, Javascript, C#', 'Jack Jones' ),
('2018-11-01', 'XYZ Company', 'Front end Developer', 'Javascript, CSS, HTML', 'Mary Jones' ),
('2018-11-02', 'OO Company', 'Back end Developer', '.NET/C#, PostgreSQL, SQL', 'Jon Jones' ),
('2018-11-03', '22 Company', 'Full Stack Developer', 'React, React Native, C#, PostgreSQL', 'Jerry Jones' );

INSERT INTO LoopUser( name, password, email )
VALUES
('James', 'james', 'james@gmail.com'),
('John', 'john', 'john@gmail.com');


INSERT INTO JobApply( date_apply, date_respond, move_forward, phone_interview_date, first_interview_date, second_interview_date,
 third_interview_date, offer_date, acceptance, joblist_id, loop_user_id)
 VALUES
 ('2018-11-05', '2018-11-10', true, '2018-11-15', 'na', 'na', 'na', 'na', false, 1, 1),
 ('2018-11-05', '2018-11-11', false, 'na', 'na', 'na', 'na', 'na', false, 2, 1),
 ('2018-11-06', '2018-11-12', true, '2018-11-18', 'na', 'na', 'na', 'na', false, 3, 1),
 ('2018-11-07', '2018-11-13', false, 'na', 'na', 'na', 'na', 'na', false, 1, 2),
 ('2018-11-07', '2018-11-13', true, '2018-11-20', 'na', 'na', 'na', 'na', false, 1, 2)