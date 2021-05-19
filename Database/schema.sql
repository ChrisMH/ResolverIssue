
CREATE TABLE tracker
(
    id serial PRIMARY KEY,
    name text NOT NULL
);


INSERT INTO tracker (name)
VALUES ('T1'), ('T2'), ('T3');
