import requests
import time

def postLocation(server, port, latitude, longitude, title, num, time, pitstop, position):
    r = requests.post('http://' + server + ':' + port +'/api/location',
                      json={'latitude':latitude, 'longitude':longitude, 'title':title,
                      'time':time, 'pitstop':pitstop, 'number':num, 'position':position})
    if r.status_code == 200 | r.status_code == 204:
        print 'Post succesful for (' + str(latitude) + ',' + str(longitude) + ')'
    else:
        print 'Post failed, Status code: ' + str(r.status_code)

team1loc = [(1.283576, 103.860626, 'Team', '1', '00:00:05', '1', '1'),
        (1.276707, 103.860300, 'Team', '1', '00:03:45', '1', '1'),
        (1.270357, 103.857596, 'Team', '1', '00:06:25', '1', '1'),
        (1.272159, 103.834551, 'Team', '1', '00:10:48', '1', '1'),
        (1.264269, 103.822303, 'Team', '1', '00:13:43', '1', '1'),
        (1.264269, 103.822303, 'Team', '1', '00:16:21', '1', '1'),
        (1.264269, 103.822303, 'Team', '1', '00:20:32', '2', '1'),
        (1.265985, 103.820457, 'Team', '1', '00:22:17', '2', '1'),
        (1.272207, 103.802390, 'Team', '1', '00:26:26', '2', '1'),
        (1.283147, 103.781919, 'Team', '1', '00:27:25', '2', '1'),
        (1.292501, 103.784881, 'Team', '1', '00:30:48', '2', '1'),
        (1.297711, 103.777486, 'Team', '1', '00:32:32', '2', '2'),
        (1.295845, 103.770963, 'Team', '1', '00:34:21', '2', '2'),
        (1.292415, 103.773980, 'Team', '1', '00:36:21', '2', '2'),
        (1.292254, 103.776609, 'Team', '1', '00:38:35', '2', '2'),
        (1.292254, 103.776609, 'Team', '1', '00:43:21', '3', '2')]
team2loc = [(1.283576, 103.860626, 'Team', '2', '00:00:08', '1', '2'),
        (1.283576, 103.860626, 'Team', '2', '00:03:42', '1', '2'),
        (1.276111, 103.854661, 'Team', '2', '00:05:32', '1', '2'),
        (1.280483, 103.852833, 'Team', '2', '00:07:43', '1', '2'),
        (1.283877, 103.851528, 'Team', '2', '00:12:56', '1', '2'),
        (1.277265, 103.834465, 'Team', '2', '00:15:21', '1', '2'),
        (1.271087, 103.826182, 'Team', '2', '00:18:32', '1', '2'),
        (1.265985, 103.820457, 'Team', '2', '00:21:17', '1', '2'),
        (1.264269, 103.822303, 'Team', '2', '00:24:26', '1', '2'),
        (1.264269, 103.822303, 'Team', '2', '00:26:25', '2', '2'),
        (1.270443, 103.811892, 'Team', '2', '00:30:48', '2', '2'),
        (1.278767, 103.784469, 'Team', '2', '00:32:32', '2', '1'),
        (1.288594, 103.778194, 'Team', '2', '00:34:43', '2', '1'),
        (1.292254, 103.776609, 'Team', '2', '00:37:21', '2', '1'),
        (1.292254, 103.776609, 'Team', '2', '00:40:34', '3', '1')]
team3loc = [(1.283576, 103.860626, 'Team', '3', '00:00:10', '1', '3'),
        (1.283576, 103.860626, 'Team', '3', '00:03:21', '1', '3'),
        (1.283576, 103.860626, 'Team', '3', '00:05:43', '1', '3'),
        (1.275244, 103.863407, 'Team', '3', '00:05:43', '1', '3'),
        (1.272069, 103.832336, 'Team', '3', '00:12:56', '1', '3'),
        (1.283576, 103.860626, 'Staff', '1', None, None, None),
        (1.277904, 103.848301, 'Staff', '1', None, None, None),
        (1.272584, 103.840748, 'Staff', '1', None, None, None),
        (1.272069, 103.832336, 'Staff', '1', None, None, None)]
pitstoploc = [(1.283576, 103.860626, 'PitStop', '1'), (1.264269, 103.822303, 'PitStop', '2'),
              (1.292254, 103.776609, 'PitStop', '3')]
staffloc = [(1.283576, 103.860626, 'Staff', '1'), (1.264269, 103.822303, 'Staff', '2'),
            (1.292254, 103.776609, 'Staff', '3')]
for i in range(len(staffloc)):
    postLocation('localhost', '62061', pitstoploc[i][0], pitstoploc[i][1], pitstoploc[i][2],
                pitstoploc[i][3], None, None, None)
    postLocation('localhost', '62061', staffloc[i][0], staffloc[i][1], staffloc[i][2],
                staffloc[i][3], None, None, None)
    
for i in range(max(len(team1loc), len(team2loc), len(team3loc))):
    if i < len(team1loc):
            postLocation('localhost', '62061', team1loc[i][0], team1loc[i][1],
            team1loc[i][2], team1loc[i][3], team1loc[i][4],
            team1loc[i][5], team1loc[i][6])
    if i < len(team2loc):
        postLocation('localhost', '62061', team2loc[i][0], team2loc[i][1],
                        team2loc[i][2], team2loc[i][3], team2loc[i][4],
            team2loc[i][5], team2loc[i][6])
    if i < len(team3loc):
        postLocation('localhost', '62061', team3loc[i][0], team3loc[i][1],
            team3loc[i][2], team3loc[i][3], team3loc[i][4],
            team3loc[i][5], team3loc[i][6])
    time.sleep(5)
