import { GET_VOCABULARY_SUCCESS, GET_VOCABULARY_ERROR, CHANGE_DESCRIPTION_SUCCESS, CHANGE_DESCRIPTION_ERROR } from './vocabularyConstants.jsx'
import "isomorphic-fetch"

export function receiveVocabulary(data) {
    return {
        type: GET_VOCABULARY_SUCCESS,
        payload: data
    };
}

export function errorReceive(err) {
    return {
        type: GET_VOCABULARY_ERROR,
        payload: err
    };
}

export function getVocabulary() {
    return (dispatch) => {
        fetch(constants.getvocabulary)
            .then((response) => {
                return response.json();
            }).then((data) => {
                dispatch(receiveVocabulary(data));
            }).catch((ex) => {
                dispatch(errorReceive(ex));
            });
    };
}

export function changeDescription(userWordId, description) {
    return (dispatch) => {
        fetch(constants.changeDescription, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ userWordId: userWordId, description: description })
        }).then((response) => {
            if (response.ok) {
                dispatch({ type: CHANGE_DESCRIPTION_SUCCESS });
                getVocabulary()(dispatch);
            } else {
                alert('Ошибка добавления комментария');
                dispatch({ type: CHANGE_DESCRIPTION_ERROR, payload: 'Ошибка добавления комментария' });
            }
        }).catch((ex) => {
            alert(ex);
            dispatch({ type: CHANGE_DESCRIPTION_ERROR, payload: ex });
        });
    }
}