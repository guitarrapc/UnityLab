Unity Benchmark for FindXxxx Method. refer : http://baba-s.hatenablog.com/entry/2014/07/09/093240

Box Environment
====

Components | Value
---- | ----
OS | Windows 10 Pro 64bit (build 14393.223)
CPU | Core-i7 6700 @3.40GHz
Memory | 32GB
GPU | GeForce 960

Benchmark
====

100 Objects
-----

Unity Version | Method | LoopCount (1000) | LoopCount (10000) | LoopCount (100000)
---- | ---- | ---- | ---- | ----
5.4.0f3 | Find | 0.003656673sec | 0.03624649sec | 0.3626404sec
5.4.0f3 | FindGameObjectWithTag | 0.0001605987sec | 0.00154953sec | 0.01507263sec
5.4.0f3 | FindObjectOfType | 0.0658863sec | 0.6607682sec | 6.645772sec

1000 Objects
-----

Unity Version | Method | LoopCount (1000) | LoopCount (10000) | LoopCount (100000)
---- | ---- | ---- | ---- | ----
5.4.0f3 | Find | 0.05269825sec | 0.5394229sec | 5.437216sec
5.4.0f3 | FindGameObjectWithTag | 0.0001548767sec | 0.001549721sec | 0.01499329sec
5.4.0f3 | FindObjectOfType | 0.1582977sec | 1.623504sec | 16.05754sec

10000 Objects
-----

Unity Version | Method | LoopCount (1000) | LoopCount (10000) | 
---- | ---- | ---- | ----
5.4.0f3 | Find | 0.8089469sec | 8.789804sec
5.4.0f3 | FindGameObjectWithTag | 0.0001621246sec | 0.00146637sec
5.4.0f3 | FindObjectOfType | 2.337319sec | 24.55924sec
